using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mutantes.Core.Exceptions;
using Mutantes.Core.Utilities;

namespace Mutantes.UnitTests
{
    [TestClass]
    public class MatrixUtilitiesTests
    {

        MatrixUtilities utilites = new MatrixUtilities();

        [TestMethod]
        [ExpectedException(typeof(NonSquareMatrixException))]
        public void Test001TratarDeConvetirUnaMatrizNoCuadradaLanzaNonSquareMatrixException()
        {
            string[] dnaList = DnaListGenerator.NonSquareMatrix();          
            utilites.getMatrixFromList(dnaList);

        }


        [TestMethod]   
        [ExpectedException(typeof(NullDnaParameterException))]
        public void Test002TratarDeConvetirUnaMatrizNulaRetornaExcepcion()
        {
             utilites.getMatrixFromList(null);
            

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCharacterInListException))]
        public void Test003TratarDeConvertirUnaListaConCaracterInvalidoLanzaInvalidCharacterInListException()
        {
            string[] dnaList = DnaListGenerator.InvalidCharMatrix();
            utilites.getMatrixFromList(dnaList);
        }


      
        [TestMethod]
        public void Test005ConvertirUnaMatrizCuadradaYCaracteresValidosFuncionaCorrectamente()
        {
            string[] dnaList = DnaListGenerator.ValidCharMatrix();
            char[,] dnaMatrix= { { 'A', 'T', 'G', 'A' }, { 'C', 'A', 'G','A' }, { 'T', 'T', 'A','A' } , { 'A', 'A', 'T', 'A' } };
            var dnaListConverted = utilites.getMatrixFromList(dnaList);
            CollectionAssert.Equals(dnaMatrix, dnaListConverted);

        }





    }
}
