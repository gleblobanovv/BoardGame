using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class GameForm : Form
    {
        private const int boardSize = 10;
        private const int cellSize = 50;

        private Dictionary<int, Color> playerColors = new Dictionary<int, Color>
        {
            { 0, Color.Red },
            { 1, Color.Blue },
            { 2, Color.Green },
            { 3, Color.Yellow }
        };

        private List<int> playerPositions = new List<int> { 1, 1, 1, 1 };
        private Dictionary<int, string> trapCells = new Dictionary<int, string>();
        private Panel boardPanel;
        private Random random = new Random();
        private SoundPlayer trapSound;
        private SoundPlayer winSound;
        private List<bool> skipTurnFlags = new List<bool> { false, false, false, false };
        private int currentPlayer = 0;

        // Пути к изображениям кубиков
        private string oneImagePath = "C:\\Users\\лобик\\Downloads\\one.png";
        private string twoImagePath = "C:\\Users\\лобик\\Downloads\\two.png";
        private string threeImagePath = "C:\\Users\\лобик\\Downloads\\three.png";
        private string fourImagePath = "C:\\Users\\лобик\\Downloads\\four.png";
        private string fiveImagePath = "C:\\Users\\лобик\\Downloads\\five.png";
        private string sixImagePath = "C:\\Users\\лобик\\Downloads\\six.png";

        public GameForm()
        {
            InitializeComponent();
            SetupBoard();
            GenerateTraps();
            trapSound = new SoundPlayer("C:\\Users\\лобик\\Downloads\\boom.wav");
            winSound = new SoundPlayer("C:\\Users\\лобик\\Downloads\\win.wav");

            buttonXod.Click += RollDice; 
            UpdatePeshkiDisplay();
        }

        private void SetupBoard()
        {
            boardPanel = new Panel
            {
                Size = new Size(boardSize * cellSize, boardSize * cellSize),
                Location = new Point(10, 10),
                BackgroundImage = Image.FromFile("C:\\Users\\лобик\\Downloads\\mapSnake.jpg"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            Controls.Add(boardPanel);
        }

        private void GenerateTraps()
        {
            trapCells.Clear();
            for (int i = 0; i < 10; i++)
            {
                int trapPosition;
                do
                {
                    trapPosition = random.Next(2, 100);
                } while (trapCells.ContainsKey(trapPosition));

                string trapType;
                int trapTypeIndex = random.Next(3);
                switch (trapTypeIndex)
                {
                    case 0:
                        trapType = "Переход вниз";
                        break;
                    case 1:
                        trapType = "Переход вверх";
                        break;
                    default:
                        trapType = "Пропуск хода";
                        break;
                }

                trapCells[trapPosition] = trapType;
            }
        }

        private void RollDice(object sender, EventArgs e)
        {
            if (skipTurnFlags[currentPlayer])
            {
                MessageBox.Show($"Игрок {currentPlayer + 1} пропускает ход!", "Пропуск хода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                skipTurnFlags[currentPlayer] = false;
                NextTurn();
                return;
            }

            // Бросаем два кубика
            int diceRoll1 = random.Next(1, 7); // Кубик 1
            int diceRoll2 = random.Next(1, 7); // Кубик 2

            // Обновляем изображения для кубиков
            cube1.Image = Image.FromFile(GetDiceImagePath(diceRoll1));
            cube2.Image = Image.FromFile(GetDiceImagePath(diceRoll2));

            // Обрабатываем ход игрока
            playerPositions[currentPlayer] = Math.Min(playerPositions[currentPlayer] + diceRoll1 + diceRoll2, 100);

            if (playerPositions[currentPlayer] == 100)
            {
                try
                {
                    winSound.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка воспроизведения звука победы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"Игрок {currentPlayer + 1} добрался до финиша и победил! 🎉", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trapCells.ContainsKey(playerPositions[currentPlayer]))
            {
                string trapEffect = trapCells[playerPositions[currentPlayer]];

                try
                {
                    trapSound.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка воспроизведения звука: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"Игрок {currentPlayer + 1} попал на ловушку! Эффект: {trapEffect}", "Ловушка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                switch (trapEffect)
                {
                    case "Переход вниз":
                        playerPositions[currentPlayer] = Math.Max(playerPositions[currentPlayer] - 5, 1);
                        break;
                    case "Переход вверх":
                        playerPositions[currentPlayer] = Math.Min(playerPositions[currentPlayer] + 5, 100);
                        break;
                    case "Пропуск хода":
                        skipTurnFlags[currentPlayer] = true;
                        break;
                }
            }

            UpdateBoard();
            NextTurn();
        }

        // Функция для получения пути к изображению кубика по числу
        private string GetDiceImagePath(int diceNumber)
        {
            switch (diceNumber)
            {
                case 1: return oneImagePath;
                case 2: return twoImagePath;
                case 3: return threeImagePath;
                case 4: return fourImagePath;
                case 5: return fiveImagePath;
                case 6: return sixImagePath;
                default: return oneImagePath; // На случай некорректного значения
            }
        }

        private void UpdateBoard()
        {
            boardPanel.Controls.Clear();
            Dictionary<int, List<int>> cellOccupancy = new Dictionary<int, List<int>>();
            for (int i = 0; i < 4; i++)
            {
                if (!cellOccupancy.ContainsKey(playerPositions[i]))
                {
                    cellOccupancy[playerPositions[i]] = new List<int>();
                }
                cellOccupancy[playerPositions[i]].Add(i);
            }

            for (int i = 0; i < 100; i++)
            {
                int row = i / 10;
                int col = (row % 2 == 0) ? i % 10 : 9 - (i % 10);
                int cellNumber = 100 - i;

                Panel cell = new Panel
                {
                    Size = new Size(cellSize, cellSize),
                    Location = new Point(col * cellSize, row * cellSize),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = trapCells.ContainsKey(cellNumber) ? Color.White : Color.Transparent
                };

                Label cellLabel = new Label
                {
                    Text = cellNumber.ToString(),
                    AutoSize = true,
                    ForeColor = Color.Black,
                    Location = new Point(5, 5)
                };
                cell.Controls.Add(cellLabel);

                if (cellOccupancy.ContainsKey(cellNumber))
                {
                    cell.BackColor = GetCellColor(cellOccupancy[cellNumber]);
                }

                boardPanel.Controls.Add(cell);
            }
        }

        private Color GetCellColor(List<int> playersOnCell)
        {
            if (playersOnCell.Count == 4)
                return Color.Black;
            if (playersOnCell.Count == 1)
                return playerColors[playersOnCell[0]];
            return Color.Gray;
        }

        private void NextTurn()
        {
            currentPlayer = (currentPlayer + 1) % 4;
            UpdatePeshkiDisplay();
        }

        private void UpdatePeshkiDisplay()
        {
            redPeshka.Visible = false;
            bluePeshka.Visible = false;
            greenPeshka.Visible = false;
            yellowPeshka.Visible = false;

            switch (currentPlayer)
            {
                case 0:
                    redPeshka.Visible = true;
                    label1.Text = "Ходит Красный игрок";
                    break;
                case 1:
                    bluePeshka.Visible = true;
                    label1.Text = "Ходит Синий игрок";
                    break;
                case 2:
                    greenPeshka.Visible = true;
                    label1.Text = "Ходит Зеленый игрок";
                    break;
                case 3:
                    yellowPeshka.Visible = true;
                    label1.Text = "Ходит Желтый игрок";
                    break;
            }
        }
    }
}
