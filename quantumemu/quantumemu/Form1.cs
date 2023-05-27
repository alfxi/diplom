using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quantumemu
{
    public partial class Form1 : Form
    {
        public int gridRows = 3;
        public int gridCols = 18;
        public int cellSize = 50;

        List<List<int>> grid = new List<List<int>>();
        List<List<Button>> buttons = new List<List<Button>>();
        List<Button> gates = new List<Button>();
        Button selectedButton = null;
        List<Color> colors = new List<Color>();

        string gateNames = "X,Y,Z,H,T,S";

        Color backgroundColor = Color.FromArgb(255, 50, 48, 48);
        Color foregroundColor = Color.FromArgb(255, 255, 255, 255);
        Color overColor = Color.FromArgb(200, 50, 48, 48);
        Color borderColor = Color.FromArgb(255, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
            this.Text = "Эмулятор квантовых схем";
            Init();
        }
        

        public void Init()
        {
            SetColors(backgroundColor, foregroundColor, overColor, borderColor);
            GridUpdate();
            GatePlacement();
        }

        public void GridUpdate()
        {
            if (grid.Count < gridRows)
            {
                int oldGridRows = grid.Count;
                for (int i = oldGridRows; i < gridRows; i++)
                {
                    grid.Add(new List<int>());
                    buttons.Add(new List<Button>());

                    for (int j = 0; j < gridCols; j++)
                    {
                        grid[i].Add(0);

                        Button button = new Button();
                        button.Location = new Point(j * cellSize, i * cellSize);
                        button.Size = new Size(cellSize, cellSize);
                        button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Regular);

                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button.ForeColor = Color.Black;
                        button.BackColor = Color.Transparent;

                        button.Click += Array_Click;

                        if (j == 0)
                        {
                            grid[i][j] = 1;
                            button.Text = "|0>";
                        }
                        buttons[i].Add(button);
                        panel1.Controls.Add(button);
                    }
                }
            }
            else if (grid.Count > gridRows) 
            {
                int oldGridRows = grid.Count - 1;
                for (int i = oldGridRows; i > gridRows-1; i--)
                {
                    List<Button> buttonsToRemove = buttons[i];
                    foreach (Button button in buttonsToRemove)
                    {
                        panel1.Controls.Remove(button);
                    }
                    buttons.RemoveAt(i);
                    grid.RemoveAt(i);
                }
            }
        }


        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the center position for each row
            int rowHeight = cellSize;
            int halfRowHeight = rowHeight / 2;

            // Create a Graphics object from the PaintEventArgs
            Graphics graphics = e.Graphics;

            // Iterate over the rows and draw a line at the center position
            for (int i = 0; i < buttons.Count; i++)
            {
                int centerY = (i * rowHeight) + halfRowHeight;
                Point startPoint = new Point(50, centerY);
                Point endPoint = new Point(gridCols * cellSize, centerY);

                // Draw the line on the panel
                Pen pen = new Pen(Color.Black, 2);
                graphics.DrawLine(pen, startPoint, endPoint);
                pen.Dispose();
            }
        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (selectedButton != clickedButton)
            {
                // Reset the visual state of the previously selected button, if any
                if (selectedButton != null)
                {
                    // Apply the desired visual changes for the deselected state
                    ChangeButtonColor(selectedButton);

                }

                // Update selectedSelfPlacedButton to the newly clicked button
                selectedButton = clickedButton;

                // Apply the desired visual changes for the selected state
                ChangeButtonColor(selectedButton);

            }
            else
            {
                ChangeButtonColor(selectedButton);
                selectedButton = null;
            }
        }
        
        public void Array_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            for (int row = 0; row < buttons.Count; row++)
            {
                for (int col = 0; col < buttons[row].Count; col++)
                {
                    if (buttons[row][col] == clickedButton)
                    {
                        if (col == 0)
                        {
                            QubitChange(clickedButton, row, col);
                        }

                        else
                        {
                            CellChange(clickedButton, row, col);
                        }
                        return;
                    }
                }
            }
        }

        public void QubitChange(Button clickedButton, int row, int col)
        {
            if (clickedButton.Text == "|0>")
            {
                clickedButton.Text = "|1>";
                grid[row][col] = 2;
            }
            else
            {
                clickedButton.Text = "|0>";
                grid[row][col] = 1;
            }
        }


        public void CellChange(Button clickedButton, int row, int col)
        {
            if (grid[row][col] == Gatetype() || selectedButton == null)
            {
                grid[row][col] = 0;

                clickedButton.Location = new Point(col * cellSize, row * cellSize);
                clickedButton.Size = new Size(cellSize, cellSize);

                clickedButton.FlatStyle = FlatStyle.Flat;
                clickedButton.FlatAppearance.BorderSize = 0;
                clickedButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                clickedButton.FlatAppearance.MouseOverBackColor = Color.Gray;
                clickedButton.BackColor = Color.Transparent;
                clickedButton.ForeColor = Color.Black;
                clickedButton.Text = null;
            }
            else
            {
                grid[row][col] = Gatetype();

                clickedButton.Location = new Point(col * cellSize + 5, row * cellSize + 5);
                clickedButton.Size = new Size(cellSize - 10, cellSize - 10);

                clickedButton.FlatStyle = FlatStyle.Flat;
                clickedButton.FlatAppearance.BorderSize = 1;
                ChangeButtonColor(clickedButton);

                clickedButton.Text = selectedButton.Text.ToString();
                
            }
            
        }

        
        public int Gatetype()
        {
            string gate = "";
            int gateNumber;
            if (selectedButton != null)
            {
                gate = selectedButton.Text.ToString();
            }
            switch (gate)
            {
                case "X":
                    gateNumber = 3;
                    break;
                case "Y":
                    gateNumber = 4;
                    break;
                case "Z":
                    gateNumber = 5;
                    break;
                case "H":
                    gateNumber = 6;
                    break;
                case "T":
                    gateNumber = 7;
                    break;
                case "S":
                    gateNumber = 8;
                    break;
                default:
                    gateNumber = 0;
                    break;
            }

            return gateNumber;
        }
        
        private void gridRowChange_IndexChanged(object sender, EventArgs e)
        {
            if (qubitCount.Text == "")
            {
                MessageBox.Show("Ошибка! Введите число кубитов от 1 до 10.");
                qubitCount.Text = "";
            }
            else if (Convert.ToInt32(qubitCount.Text) > 6 || Convert.ToInt32(qubitCount.Text) < 1)
            {
                MessageBox.Show("Ошибка! Введите число кубитов от 1 до 10.");
                qubitCount.Text = "";
            }
            else
            {
                gridRows = Convert.ToInt32(qubitCount.Text);
                GridUpdate();
            }
        }

        private void Measure_Click(object sender, EventArgs e)
        {
            List<Qubit> qubitArray = new List<Qubit>();

            // Initialize qubits based on the circuit grid
            for (int j = 0; j < gridRows; j++)
            {
                Qubit qubit = new Qubit();
                if (grid[j][0] == 1)
                {
                    // Set qubit state to |0>
                    qubitArray.Add(qubit);
                }
                else
                {
                    // Set qubit state to |1>
                    qubit.ApplyXGate();
                    qubitArray.Add(qubit);
                }
            }

            // Apply gates to the qubits based on the circuit grid
            for (int i = 0; i < gridCols; i++)
            {
                for (int j = 0; j < gridRows; j++)
                {
                    if (i == 0)
                    {
                        // Skip the first column since qubits are already initialized
                        continue;
                    }

                    int gateType = grid[j][i];
                    Qubit qubit = qubitArray[j];

                    switch (gateType)
                    {
                        case 3:
                            qubit.ApplyXGate();
                            break;
                        case 4:
                            qubit.ApplyYGate();
                            break;
                        case 5:
                            qubit.ApplyZGate();
                            break;
                        case 6:
                            qubit.ApplyHGate();
                            break;
                        case 7:
                            qubit.ApplyTGate();
                            break;
                        case 8:
                            qubit.ApplySGate();
                            break;
                        default:
                            break;
                    }
                }
            }

            // Calculate the probabilities for each qubit before measuring
            List<double[]> amplitudesList = new List<double[]>();

            foreach (Qubit qubit in qubitArray)
            {
                double[] amplitudes = qubit.GetAmplitudes();
                amplitudesList.Add(amplitudes);
            }

            // Measure each qubit and collect the outcomes
            List<int> measurementOutcomes = new List<int>();

            foreach (Qubit qubit in qubitArray)
            {
                int outcome = qubit.Measure();
                measurementOutcomes.Add(outcome);
            }

            // Display the measurement outcomes and pre-measurement probabilities in a message box
            string[] message = new string[gridRows];
            panelResult.Controls.Clear();
            for (int i = 0; i < measurementOutcomes.Count; i++)
            {
                int outcome = measurementOutcomes[i];
                double[] amplitudes = amplitudesList[i];

                double percentZero = amplitudes[0] * 100;
                double percentOne = amplitudes[1] * 100;

                Label result = new Label();

                result.Font = new Font(result.Font.FontFamily, 10, FontStyle.Regular);
                result.ForeColor = Color.White;
                result.Text = $"Кубит {i + 1}: {outcome}\n";
                result.Text += $"Вероятности состояний:\n";
                result.Text += $"|0>: {percentZero:F2}%\n";
                result.Text += $"|1>: {percentOne:F2}%";

                result.Location = new Point(i * 100, 20);
                result.Size = new Size(100, 100);

                panelResult.Controls.Add(result);
            }
            panelResult.Visible = true;
            resultMessage.Visible = true;
        }

        private void ClearCircuit()
        {
            // Suspend the layout logic of the panel
            panel1.SuspendLayout();

            // Clear the grid and buttons lists
            grid.Clear();
            buttons.Clear();

            // Clear the panel controls
            panel1.Controls.Clear();

            // Reinitialize the grid and buttons with default values
            for (int i = 0; i < gridRows; i++)
            {
                grid.Add(new List<int>());
                buttons.Add(new List<Button>());

                for (int j = 0; j < gridCols; j++)
                {
                    grid[i].Add(0);

                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Regular);

                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.ForeColor = Color.Black;
                    button.BackColor = Color.Transparent;

                    button.Click += Array_Click;

                    if (j == 0)
                    {
                        grid[i][j] = 1;
                        button.Text = "|0>";
                    }
                    buttons[i].Add(button);
                    panel1.Controls.Add(button);
                }
            }
            // Resume the layout logic of the panel
            panel1.ResumeLayout();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCircuit();
        }

        private void SaveLayout(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Save grid dimensions
                    writer.WriteLine($"{gridRows},{gridCols}");

                    // Save grid state
                    for (int i = 0; i < gridRows; i++)
                    {
                        for (int j = 0; j < gridCols; j++)
                        {
                            if (j == 0)
                            {
                                writer.Write($"{grid[i][j]}");
                            }
                            else
                            {
                                writer.Write($",{grid[i][j]}");
                            }
                            
                        }
                        writer.WriteLine();
                    }
                    // Save button text
                    for (int i = 0; i < gridRows; i++)
                    {
                        for (int j = 0; j < gridCols; j++)
                        {
                            if (j == 0)
                            {
                                writer.Write($"{buttons[i][j].Text}");
                            }
                            else
                            {
                                writer.Write($",{buttons[i][j].Text}");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении цепи: {ex.Message}");
            }
        }

        private void LoadLayout(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Parse the number of rows and columns from the first line
                string[] size = lines[0].Split(',');
                int rows = int.Parse(size[0]);
                int cols = int.Parse(size[1]);

                // Update gridRows and gridCols variables
                gridRows = rows;
                gridCols = cols;

                panel1.Controls.Clear();
                // Update the grid and buttons lists with appropriate sizes
                grid.Clear();
                for (int i = 1; i <= rows; i++)
                {
                    grid.Add(new List<int>());
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < cols; j++)
                    {
                        grid[i - 1].Add(Convert.ToInt32(values[j]));
                    }
                }

                buttons.Clear();
                int q = -1;
                for (int i = rows + 1; i <= rows * 2; i++)
                {
                    buttons.Add(new List<Button>());
                    q++;
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < cols; j++)
                    {
                        Button button = new Button();
                        
                        if (values[j] == "")
                        {
                            button.Location = new Point(j * cellSize, q * cellSize);
                            button.Size = new Size(cellSize, cellSize);
                            button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Regular);

                            button.FlatStyle = FlatStyle.Flat;
                            button.FlatAppearance.BorderSize = 0;
                            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            button.FlatAppearance.MouseOverBackColor = Color.Gray;
                            button.BackColor = Color.Transparent;
                            button.ForeColor = Color.Black;
                        }
                        else if (grid[q][j] == 1 || grid[q][j] == 2)
                        {
                            button.Location = new Point(j * cellSize, q * cellSize);
                            button.Size = new Size(cellSize, cellSize);
                            button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Regular);

                            button.FlatStyle = FlatStyle.Flat;
                            button.FlatAppearance.BorderSize = 0;
                            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.Transparent;

                            button.Text = values[j];
                        }
                        else
                        {
                            button.Location = new Point(j * cellSize + 5, q * cellSize + 5);
                            button.Size = new Size(cellSize - 10, cellSize - 10);
                            button.FlatStyle = FlatStyle.Flat;
                            button.FlatAppearance.BorderSize = 1;
                            ChangeButtonColor(button);

                            button.Text = values[j];
                        }
                        
                        button.Click += Array_Click;
                        buttons[q].Add(button);
                        panel1.Controls.Add(button);
                    }
                }
                MessageBox.Show("Цель загруженна успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке квантовой цепи: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveLayout(filePath);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadLayout(filePath);
            }
        }

        public void GatePlacement()
        {
            string[] gateLine = gateNames.Split(',');
            

            int k = gateLine.Length;

            for (int i = 0; i < k; i++)
            {
                Button button = new Button();

                button.FlatStyle = FlatStyle.Flat;
                button.Location = new Point(i * 60, 0);
                button.Size = new Size(60, 60);
                ChangeButtonColor(button);
                button.Text = gateLine[i];
                button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Regular);
                button.Name = gateLine[i];

                button.Click += Button_Click;

                gates.Add(button);
                panelGates.Controls.Add(button);
            }
        }

        public void ChangeButtonColor(Button button)
        {
            button.BackColor = colors[0];
            button.ForeColor = colors[1];
            button.FlatAppearance.MouseOverBackColor = colors[2];
            button.FlatAppearance.BorderColor = colors[3];
        }

        public void SetColors(Color backgroundColor, Color foregroundColor, Color overColor, Color borderColor)
        {
            colors.Clear();
            colors.Add(backgroundColor);
            colors.Add(foregroundColor);
            colors.Add(overColor);
            colors.Add(borderColor);
        }
    }
}