namespace _4BitCPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CPU4 cpu = new CPU4();
        private void Form1_Load(object sender, EventArgs e)
        {
            cpu.init();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            cpu.tick();
            label1.Text = cpu.regA +"|" +cpu.regB+'|'+cpu.programCounter;

            int i = 0;
            foreach (byte b in cpu.ram)
            {
                lbxRAM.Items[i] = (b.ToString());
                i++;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cpu.init();
            cpu.loadProgram(rtbProgram.Text.Replace(" ", ""));
        }

        private void tbrClockSpeed_Scroll(object sender, EventArgs e)
        {
            tmrTick.Interval = tbrClockSpeed.Value;
        }

        private void cbxClockEnabled_CheckedChanged(object sender, EventArgs e)
        {
            tmrTick.Enabled = cbxClockEnabled.Checked;
        }
    }
}