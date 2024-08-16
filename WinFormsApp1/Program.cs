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
                // Form ayarlarý
                this.Text = "Basit Windows Form";
                this.Size = new System.Drawing.Size(300, 200);

                // Label oluþturma ve ayarlarý
                myLabel = new Label();
                myLabel.Text = "Merhaba, Dünya!";
                myLabel.Location = new System.Drawing.Point(100, 50);
                myLabel.AutoSize = true;

                // Button oluþturma ve ayarlarý
                myButton = new Button();
                myButton.Text = "Týkla Beni";
                myButton.Location = new System.Drawing.Point(100, 100);
                myButton.Click += new EventHandler(Button_Click);

                // Form'a kontrolleri ekle
                this.Controls.Add(myLabel);
                this.Controls.Add(myButton);
            }

            // Button týklama olayý
            private void Button_Click(object sender, EventArgs e)
            {
                myLabel.Text = "Butona týklandý!";
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