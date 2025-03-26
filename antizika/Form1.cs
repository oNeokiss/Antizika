using System.Security.Cryptography;

namespace antizika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Hash_Click(object sender, EventArgs e)
        {
            //abrir windows explorer

            using (OpenFileDialog dialogoAbrirArquivo = new OpenFileDialog())
            {
                dialogoAbrirArquivo.Filter = "Todos os arquivos (*.*)|*.*";

                if (dialogoAbrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    //armazena o caminho do arquivo

                    string caminhoArquivo = dialogoAbrirArquivo.FileName;

                   //calcula hash
                   string hashSHA256 = CalculaHash256(caminhoArquivo);
                    Clipboard.SetText(hashSHA256);
                    MessageBox.Show("Hash Colado na área de transferência");
                }
            }

            
        }

        //calcular hash SHA¨256

        private string CalculaHash256(string caminhoArquivo)
        {
            using (FileStream fs = File.OpenRead(caminhoArquivo)) //abre arquivo
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(fs);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            }
        }
    }
}
