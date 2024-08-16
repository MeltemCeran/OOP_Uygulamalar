namespace WinFormsApp1
{
    internal static class Program
    {
        
        public class MyForm : Form
        {
            private Button myButton;
            private Label myLabel;

            public MyForm()
            {
                // Form ayarlar�
                this.Text = "Basit Windows Form";
                this.Size = new System.Drawing.Size(300, 200);

                // Label olu�turma ve ayarlar�
                myLabel = new Label();
                myLabel.Text = "Merhaba, D�nya!";
                myLabel.Location = new System.Drawing.Point(100, 50);
                myLabel.AutoSize = true;

                // Button olu�turma ve ayarlar�
                myButton = new Button();
                myButton.Text = "T�kla Beni";
                myButton.Location = new System.Drawing.Point(100, 100);
                myButton.Click += new EventHandler(Button_Click);

                // Form'a kontrolleri ekle
                this.Controls.Add(myLabel);
                this.Controls.Add(myButton);
            }

            // Button t�klama olay�
            private void Button_Click(object sender, EventArgs e)
            {
                myLabel.Text = "Butona t�kland�!";
            }

            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new MyForm());
            }
        }
    }
}