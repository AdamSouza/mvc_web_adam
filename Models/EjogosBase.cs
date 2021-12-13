using System.IO;

namespace e_jogos.Models
{
    public class EjogosBase
    {
        //criar uma função para criar a pasta e o arquivo.
        //string path é o parâmetro da função, que terá o caminho para análise.
        public void CreateFolderAndFile(string path)
        {
            // formato: pasta/arquivo.csv
            string folder = path.Split('/')[0];
            string file = path.Split('/')[1];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(file))
            {
                File.Create(path);
            }

        }
    }
}
