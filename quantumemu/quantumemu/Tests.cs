using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quantumemu.Tests
{
    [TestFixture]
    public class Form1Tests
    {
        private Form1 form;

        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

        [Test]
        public void Init_InitializesFormWithCorrectProperties()
        {
            // Act
            form.Init();

            // Assert
            Assert.AreEqual(form.gridRows, 3);
            Assert.AreEqual(form.gridCols, 18);
            Assert.AreEqual(form.cellSize, 50);
            Assert.IsNotNull(form.grid);
            Assert.IsNotNull(form.buttons);
            Assert.IsNotNull(form.gates);
            Assert.IsNull(form.selectedButton);
            Assert.IsNotNull(form.colors);
            Assert.AreEqual(form.colors.Count, 0);
        }

        [Test]
        public void GridUpdate_AddsButtonsToPanel()
        {
            // Arrange
            form.gridRows = 2;
            form.gridCols = 3;

            // Act
            form.GridUpdate();

            // Assert
            Assert.AreEqual(form.panel1.Controls.Count, 6);
            for (int i = 0; i < form.gridRows; i++)
            {
                for (int j = 0; j < form.gridCols; j++)
                {
                    Assert.IsInstanceOf<Button>(form.panel1.Controls[i * form.gridCols + j]);
                }
            }
        }

        [Test]
        public void QubitChange_SwitchesQubitStateCorrectly()
        {
            // Arrange
            Button button = new Button();
            button.Text = "|0>";
            int row = 1;
            int col = 0;

            // Act
            form.QubitChange(button, row, col);

            // Assert
            Assert.AreEqual(button.Text, "|1>");
            Assert.AreEqual(form.grid[row][col], 2);

            // Act
            form.QubitChange(button, row, col);

            // Assert
            Assert.AreEqual(button.Text, "|0>");
            Assert.AreEqual(form.grid[row][col], 1);
        }

        [Test]
        public void CellChange_ModifiesCellPropertiesCorrectly()
        {
            // Arrange
            Button button = new Button();
            button.Text = null;
            int row = 1;
            int col = 1;
            form.selectedButton = new Button();
            form.selectedButton.Text = "X";

            // Act
            form.CellChange(button, row, col);

            // Assert
            Assert.AreEqual(form.grid[row][col], 3);
            Assert.AreEqual(button.Location, new System.Drawing.Point(col * form.cellSize + 5, row * form.cellSize + 5));
            Assert.AreEqual(button.Size, new System.Drawing.Size(form.cellSize - 10, form.cellSize - 10));
            Assert.AreEqual(button.FlatStyle, FlatStyle.Flat);
            Assert.AreEqual(button.FlatAppearance.BorderSize, 1);
            Assert.AreEqual(button.ForeColor, Color.White);
            Assert.AreEqual(button.Text, "X");

            // Act
            form.CellChange(button, row, col);

            // Assert
            Assert.AreEqual(form.grid[row][col], 0);
            Assert.AreEqual(button.Location, new System.Drawing.Point(col * form.cellSize, row * form.cellSize));
            Assert.AreEqual(button.Size, new System.Drawing.Size(form.cellSize, form.cellSize));
            Assert.AreEqual(button.FlatStyle, FlatStyle.Flat);
            Assert.AreEqual(button.FlatAppearance.BorderSize, 0);
            Assert.AreEqual(button.FlatAppearance.MouseDownBackColor, Color.Transparent);
            Assert.AreEqual(button.BackColor, Color.Transparent);
            Assert.AreEqual(button.ForeColor, Color.Black);
            Assert.AreEqual(button.Text, null);
        }

        [Test]
        public void MeasureQubits_CorrectlyUpdatesQubitStates()
        {
            // Arrange
            form.grid = new int[2][];
            form.grid[0] = new int[3] { 1, 2, 0 };
            form.grid[1] = new int[3] { 0, 1, 2 };
            List<Button> buttons = new List<Button>();
            Button button1 = new Button();
            button1.Text = "|0>";
            Button button2 = new Button();
            button2.Text = "|1>";
            Button button3 = new Button();
            button3.Text = "|0>";
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);

            // Act
            form.MeasureQubits(buttons);

            // Assert
            Assert.AreEqual(buttons[0].Text, "|0>");
            Assert.AreEqual(buttons[1].Text, "|1>");
            Assert.AreEqual(buttons[2].Text, "|0>");
        }
    }
}
