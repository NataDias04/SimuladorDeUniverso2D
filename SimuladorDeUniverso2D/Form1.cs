using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorDeUniverso2D
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Universo universo;

        public Form1()
        {
            InitializeComponent();
            universo = new Universo();
            timer = new System.Windows.Forms.Timer
            {
                Interval = 100 // 100 ms
            };
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            universo.AtualizarInteracoes(0.1); // Atualiza o universo
            displayPanel.Invalidate(); // Solicita redesenho
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            foreach (var corpo in universo.GetCorpos())
            {
                float x = (float)corpo.GetPosX();
                float y = (float)corpo.GetPosY();
                float raio = (float)corpo.GetRaio();
                g.FillEllipse(Brushes.Blue, x - raio / 2, y - raio / 2, raio, raio);
            }
        }
    }
}
