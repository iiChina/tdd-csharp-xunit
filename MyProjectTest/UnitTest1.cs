// using Xunit;

// namespace MyProjectTest;

// public class UnitTest1
// {
//     [Fact]
//     public void Test1()
//     {

//     }

//     /* Teste de 3 passos */
//     public void StructAAA()
//     {
//         // Arrange
//         var cpf = "111.111.111-11";
//         var expected = false;
//         // Act
//         var result = ValidaCpf(cpf);
//         //Assert
//         Assert.False(result);
//         Assert.Equal(expected, result);
//     }

//     /* Teste de 4 passos */
//     public void StructSEVT()
//     {
//         // Setup (Preparar)
//         var cpf = "111.111.111-11";
//         var expected = false;
//         // Exercise (Agir)
//         var result = ValidaCpf(cpf);
//         // Verify (Verificar)
//         Assert.False(result);
//         Assert.Equal(expected, result)
//         // Teardown (Limpar / Destruir)
//         cpf = null;
//     }

//     /* Teste de 5 passos */
//     public void StructSAAAT()
//     {
//         // Setup (Preparar Geral)
//         var cpf = "111.111.111-11";
//         var expected = false;
//         // Arrange (Preparar Específico)
//         var result = ValidaCpf(cpf);
//         // Act (Agir)
//         Assert.False(result);
//         Assert.Equal(expected, result)
//         // Assert (Verificar)
//         cpf = null;
//         // Teardown (Limpar / Destruir)
//     } 
// }

