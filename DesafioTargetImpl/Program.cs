// See https://aka.ms/new-console-template for more information

using DesafioTargetImpl;
using DesafioTargetImpl.Desafio_1;
using DesafioTargetImpl.Desafio_2;
using DesafioTargetImpl.Desafio_3;
using DesafioTargetImpl.Desafio_4;
using DesafioTargetImpl.Desafio_5;


IDesafio desafio1 = new Desafio1();
IDesafio desafio2 = new Desafio2();
IDesafio desafio3 = new Desafio3();
IDesafio desafio4 = new Desafio4();
IDesafio desafio5 = new Desafio5();
List<IDesafio> desafios = new List<IDesafio> { desafio1, desafio2, desafio3, desafio4, desafio5 };
DesafioHandler handler = new DesafioHandler(desafios);
handler.Run();


