namespace Classes.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z)
        {
            this.z = z;
            CalcularDistancia();
        }
    }
}