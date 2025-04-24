using System;
//dotnet run 
namespace AbstractFactoryExample
{
    // Interfaz para las sillas
    public interface ISilla
    {
        void Sentarse();
    }

    // Interfaz para las mesas
    public interface IMesa
    {
        void Usar();
    }

    // Interfaz para los sofás
    public interface ISofa
    {
        void Sentarse();
    }

    // Clases concretas para muebles Modernos
    public class SillaModerna : ISilla
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en una silla moderna.");
        }
    }

    public class MesaModerna : IMesa
    {
        public void Usar()
        {
            Console.WriteLine("Estás usando una mesa moderna.");
        }
    }

    public class SofaModerno : ISofa
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en un sofá moderno.");
        }
    }

    // Clases concretas para muebles Clásicos
    public class SillaClasica : ISilla
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en una silla clásica.");
        }
    }

    public class MesaClasica : IMesa
    {
        public void Usar()
        {
            Console.WriteLine("Estás usando una mesa clásica.");
        }
    }

    public class SofaClasico : ISofa
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en un sofá clásico.");
        }
    }

    // Clases concretas para muebles Art Decó
    public class SillaArtDeco : ISilla
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en una silla Art Decó elegante.");
        }
    }

    public class MesaArtDeco : IMesa
    {
        public void Usar()
        {
            Console.WriteLine("Estás usando una mesa Art Decó sofisticada.");
        }
    }

    public class SofaArtDeco : ISofa
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en un sofá Art Decó de lujo.");
        }
    }

    // Fábrica Abstracta (clase base)
    public abstract class MueblesFactory
    {
        public abstract ISilla CrearSilla();
        public abstract IMesa CrearMesa();
        public abstract ISofa CrearSofa(); 
    }

    // Fábrica concreta para muebles Modernos
    public class MueblesModernosFactory : MueblesFactory
    {
        public override ISilla CrearSilla()
        {
            return new SillaModerna();
        }

        public override IMesa CrearMesa()
        {
            return new MesaModerna();
        }

        public override ISofa CrearSofa()
        {
            return new SofaModerno();
        }
    }

    // Fábrica concreta para muebles Clásicos
    public class MueblesClasicosFactory : MueblesFactory
    {
        public override ISilla CrearSilla()
        {
            return new SillaClasica();
        }

        public override IMesa CrearMesa()
        {
            return new MesaClasica();
        }

        public override ISofa CrearSofa()
        {
            return new SofaClasico();
        }
    }

    // Fábrica concreta para muebles Art Decó
    public class MueblesArtDecoFactory : MueblesFactory
    {
        public override ISilla CrearSilla()
        {
            return new SillaArtDeco();
        }

        public override IMesa CrearMesa()
        {
            return new MesaArtDeco();
        }

        public override ISofa CrearSofa()
        {
            return new SofaArtDeco();
        }
    }

    // Cliente que usa la fábrica abstracta
    class Cliente
    {
        private ISilla _silla;
        private IMesa _mesa;
        private ISofa _sofa;

        public Cliente(MueblesFactory factory)
        {
            _silla = factory.CrearSilla();
            _mesa = factory.CrearMesa();
            _sofa = factory.CrearSofa();
        }

        public void UsarMuebles()
        {
            _silla.Sentarse();
            _mesa.Usar();
            _sofa.Sentarse();
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente usando muebles modernos
            Console.WriteLine("Creando muebles modernos:");
            MueblesFactory fabricaModerna = new MueblesModernosFactory();
            Cliente cliente1 = new Cliente(fabricaModerna);
            cliente1.UsarMuebles();

            // Cliente usando muebles clásicos
            Console.WriteLine("\nCreando muebles clásicos:");
            MueblesFactory fabricaClasica = new MueblesClasicosFactory();
            Cliente cliente2 = new Cliente(fabricaClasica);
            cliente2.UsarMuebles();

            // Cliente usando muebles Art Decó
            Console.WriteLine("\nCreando muebles Art Decó:");
            MueblesFactory fabricaArtDeco = new MueblesArtDecoFactory();
            Cliente cliente3 = new Cliente(fabricaArtDeco);
            cliente3.UsarMuebles();
        }
    }
}
