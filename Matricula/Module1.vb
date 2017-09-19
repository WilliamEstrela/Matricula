Module Module1
    'Implementem utilizando todos os conceitos vistos até a data de hoje, TUDO!!, 
    'incluindo documentação e testes.'
    'Um estudante(matrícula de 14 dígitos, nome, matriculado(True Or False)),podem ser de 
    'dois cursos. Computação e Engenharia. Alunos de computação possuem o 5º e 6º número como 14 e
    'engenharia 13.   A matrícula é feita apenas até o dia 08/09/2017 ,porém uma matrícula pode ser 
    'cancelada a qualquer momento.'
    Sub Main()

        Dim Aluno1 As New Aluno(200, "william", True, 1)

        Aluno1.matriculado = True


        Console.WriteLine("Matricula: " & Aluno1.matricula())
        Console.WriteLine("Status da matricula: " & Aluno1.matriculado())
        Console.WriteLine("Nome: " & Aluno1.nome)
    End Sub

End Module