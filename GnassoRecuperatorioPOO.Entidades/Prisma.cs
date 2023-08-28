using System.Text;

namespace GnassoRecuperatorioPOO.Entidades
{
    public class Prisma
    {

        private int _largo;
        private int _altura;
        private int _ancho;

        public int  GetLargo()
        {
            return _largo;
        }
        public int  GetAltura()
        {
            return _altura;
        } 
        public int GetAncho()
        {
            return _ancho;
        }


        public Prisma(int largo, int altura, int ancho)
        {

            if(largo<= 0 || altura<=0 || ancho<= 0)
            {
                throw new ArgumentException("Valores no validos!!!");
            }


            _largo = largo;
            _altura = altura;
            _ancho = ancho;

        }


        public Prisma() :this(1,1,1) 
        {
            
        }


        private double GetAreaBase(int largo, int ancho)
        {
            return largo * ancho;
        }

        private double GetAreaAltura(int altura, int ancho)
        {
            return altura * ancho;
        }

        private double GetAreaAncho(int altura, int largo)
        {
            return altura * largo;
        }

        public double GetAreaPrisma( int largo, int ancho, int altura )
        {
            return 2 * (GetAreaBase(largo, ancho) + GetAreaAltura(altura, ancho) + GetAreaAncho(altura, largo));
        }

        public double GetVolumenPrisma(int largo,int ancho, int altura)
        {
            return largo * ancho * altura;

        }

        public double GetDiagonal(int largo, int ancho, int altura)
        {
            return Math.Sqrt( Math.Pow(largo, 2) +  Math.Pow(ancho, 2) + Math.Pow(altura, 2));
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Prisma rectangular:");
            datos.AppendLine($"Largo: {_largo}");
            datos.AppendLine($"Ancho: {_ancho}");
            datos.AppendLine($"ALtura: {_altura}");
            datos.AppendLine($"Area de la base: {GetAreaBase(_largo, _ancho)}");
            datos.AppendLine($"Area de la altura: {GetAreaAltura(_altura, _ancho)}");
            datos.AppendLine(($"Area del ancho: {GetAreaAncho(_altura, _largo)}"));
            datos.AppendLine($"Area del prisma: {GetAreaPrisma(_largo, _ancho, _altura)}");
            datos.AppendLine($"Volumen del prisma: {GetVolumenPrisma(_largo, _ancho, _altura)}");
            datos.AppendLine($"Disgonal: {GetDiagonal(_largo, _ancho, _altura)}");

            return datos.ToString();
        }
    }
}