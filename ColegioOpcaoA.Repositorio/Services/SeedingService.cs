//using Castle.DynamicProxy.Generators;
using ColegioOpcaoA.Dominio.Entidades;
using ColegioOpcaoA.Dominio.Enumerados;
using ColegioOpcaoA.Repositorio.Contexto;
using System;
using System.Linq;

namespace ColegioOpcaoA.Repositorio.Services
{
    public class SeedingService
    {
        private ColegioOpcaoAContexto _contexto;

        public SeedingService(ColegioOpcaoAContexto contexto)
        {
            _contexto = contexto;
        }

        public void Seed()
        {
            if (_contexto.Alunos.Any() ||
                _contexto.Turmas.Any() ||
                _contexto.Provas.Any())
            {
                return; // O banco de dados já foi populado
            }

            Turma t1 = new Turma(1,"1001");
            Turma t2 = new Turma(2, "1002");
            Turma t3 = new Turma(3, "1003");
            _contexto.Turmas.AddRange(t1, t2, t3);
           // _contexto.SaveChanges();

            Aluno[] alunos = new Aluno[60];
            alunos[0] = new Aluno(1, "Amandio Dâmaso", t1);
            alunos[1] = new Aluno(2, "André Torcuato",t1);
            alunos[2] = new Aluno(3,"Angelino Sousa de Arronches",t1);
            alunos[3] = new Aluno(4,"Aníbal Estrella",t1);
            alunos[4] = new Aluno(5,"Duarte Cintra", t1);
            alunos[5] = new Aluno(6,"Délia Cardozo", t1);
            alunos[6] = new Aluno(7,"Honório Norões", t1);
            alunos[7] = new Aluno(8,"Justino González", t1);
            alunos[8] = new Aluno(9,"Júlia Padilha", t1);
            alunos[9] = new Aluno(10,"Mamede Saraíba", t1);
            alunos[10] = new Aluno(11,"Mateus Jordão", t1);
            alunos[11] = new Aluno(12,"Miru Ribas", t1);
            alunos[12] = new Aluno(13,"Rita Salomão", t1);
            alunos[13] = new Aluno(14,"Roberta Rolim", t1);
            alunos[14] = new Aluno(15,"Romano Bulhosa", t1);
            alunos[15] = new Aluno(16,"Salomé Ferraz", t1);
            alunos[16] = new Aluno(17,"Salvador Imbassaí", t1);
            alunos[17] = new Aluno(18,"Sílvia Amado", t1);
            alunos[18] = new Aluno(19,"Tadeu Frois", t1);
            alunos[19] = new Aluno(20,"Trajano Mirandela", t1);
            alunos[20] = new Aluno(21,"Zuleica Rua", t2);
            alunos[21] = new Aluno(22, "Érico Severiano", t2);
            alunos[22] = new Aluno(23, "Vânia Souto Maior", t2);
            alunos[23] = new Aluno(24, "Virgínia Mirandela", t2);
            alunos[24] = new Aluno(25, "Vanderlei Casado", t2);
            alunos[25] = new Aluno(26, "Tarrataca Vilar", t2);
            alunos[26] = new Aluno(27, "Silvana Santarém", t2);
            alunos[27] = new Aluno(28, "Rui Vega", t2);
            alunos[28] = new Aluno(29, "Rosa Balsemão", t2);
            alunos[29] = new Aluno(30, "Ronaldo Ulhoa", t2);
            alunos[30] = new Aluno(31, "Ramão Coitinho", t2);
            alunos[31] = new Aluno(32, "Patrícia Anlicoara", t2);
            alunos[32] = new Aluno(33, "Parcidio Núñez", t2);
            alunos[33] = new Aluno(34, "Palmira Souto", t2);
            alunos[34] = new Aluno(35, "Osvaldo Fartaria", t2);
            alunos[35] = new Aluno(36, "Oscar   Anlicoara", t2);
            alunos[36] = new Aluno(37, "Odilia Severiano", t2);
            alunos[37] = new Aluno(38, "Mercedes Bonilla", t2);
            alunos[38] = new Aluno(39, "Mateus Pêssego", t2);
            alunos[39] = new Aluno(40, "Luciano Torres", t2);
            alunos[40] = new Aluno(41, "Luciana Caiado", t3);
            alunos[41] = new Aluno(42, "Leónidas Zarco", t3);
            alunos[42] = new Aluno(43, "Judite Regueira", t3);
            alunos[43] = new Aluno(44, "Judas Ferreira", t3);
            alunos[44] = new Aluno(45, "Josefina Vigário", t3);
            alunos[45] = new Aluno(46, "Jeremias Estrella", t3);
            alunos[46] = new Aluno(47, "Hermano Collaço", t3);
            alunos[47] = new Aluno(48, "Estefânia Sequeira", t3);
            alunos[48] = new Aluno(49, "Domingos Clementino", t3);
            alunos[49] = new Aluno(50, "Crispim Torquato", t3);
            alunos[50] = new Aluno(51, "Cleusa Sant'Anna", t3);
            alunos[51] = new Aluno(52, "Celina Nunes", t3);
            alunos[52] = new Aluno(53, "Casimiro Mendonça", t3);
            alunos[53] = new Aluno(54, "Carlos Caminha", t3);
            alunos[54] = new Aluno(55, "Caetana Veríssimo", t3);
            alunos[55] = new Aluno(56, "Berengário Salgado", t3);
            alunos[56] = new Aluno(57, "Belmiro Sacadura", t3);
            alunos[57] = new Aluno(58, "Belmiro Carvalho", t3);
            alunos[58] = new Aluno(59, "Belmifer Beserril", t3);
            alunos[59] = new Aluno(60, "Amílcar Soeiro", t3);

            for (int i = 0; i < 60; i++)
            {
                _contexto.Alunos.Add(alunos[i]);
                Random random = new Random();
                double nota = random.Next(0,101) / 10.0;
                Prova p1 = new Prova(TipoProvaEnum.P1, nota, alunos[i]);
                nota = random.Next(0,101) / 10.0;
                Prova p2 = new Prova(TipoProvaEnum.P2, nota, alunos[i]);
                nota = random.Next(0,101) / 10.0;
                Prova p3 = new Prova(TipoProvaEnum.P3, nota, alunos[i]);
                _contexto.Provas.AddRange(p1, p2, p3);
            }
            _contexto.SaveChanges();
        }
    }
}
