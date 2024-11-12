using System;


namespace map
{
    class Map
    {
        private int[] tamanho = new int[2];
        private string terreno = "";

        public string _terreno
        {
            get{return terreno;}
            set{terreno = value;}
        }
        public int[] _tamanho
        {
            get{return tamanho;}
        }
        public void _setTamanho(int a, int b)
        {
            tamanho[0] = a;
            tamanho[1] = b;
        }

        public void Create(int a, int b, string c)
        {
            
            for (int i=0; i < tamanho[0]; i++)
            {
                string linha = "";
                for (int j=0;j<tamanho[1]; j++)
                {
                    if (j == b && i == a)
                    {
                        linha += c;
                    }
                    else
                    {
                        linha += terreno;
                    }
                }
                Console.WriteLine(linha);
            }
        }

    }
}