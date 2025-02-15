using ProjetoAulas.Models.Moto;

var moto = new MotoTeste();

moto.IniciarPartida();
moto.Dirigir(5, 20);

double velocidade = moto.VerificarVelocidadeMaxima();

Console.WriteLine("A velocidade máxima é de {0}", velocidade);