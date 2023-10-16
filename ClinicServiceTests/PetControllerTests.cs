using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class PetControllerTests
    {
        private PetController _petController;
        private Mock<IPetRepository> _mocPetRepository;
        public PetControllerTests()
        {
            _mocPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mocPetRepository.Object);

        }
        [Fact]
        public void GetAllPetsTest()
        {
            // [1.1] Подготовка данных для тестирования

            // [1.2]

            List<Pet> list = new List<Pet>();
            list.Add(new Pet());
            list.Add(new Pet());
            list.Add(new Pet());


            _mocPetRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            // [2] Исполнение тестируемого метода

            _petController.GetAll();
            var operationResult = _petController.GetAll();

            // [3] Подготовка эталонногорезультата, проверка результата
            _mocPetRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());

        }
    }
}
