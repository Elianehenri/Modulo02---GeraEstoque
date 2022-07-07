
using System.Data.SqlClient;
using System.Text;




namespace modulo2_semana6_tests
{
    public class UnitTest1
    {

        //metodo input true e return false

        [Fact]
        public void Test1()
        {
            var result = true;
            Assert.True(result, "Erro no método");
        }

 //       try 
	//{	        
		
	//}
	//catch (global::System.Exception)
	//{

	//	throw;
	//}



    }
    [Serializable]
    public class CustomErrorException : Exception
    {
        public CustomErrorException()
        {

        }

        public CustomErrorException(string mensagemErro) : base(mensagemErro)
        {

        }
    }

}