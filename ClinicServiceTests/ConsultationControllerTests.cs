using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ConsultationControllerTests
    {
        private ConsultationController _ConsultationController;
        private Mock<IConsultationRepository> _mocConsultationRepository;
        public ConsultationControllerTests()
        {
            _mocConsultationRepository = new Mock<IConsultationRepository>();
            _ConsultationController = new ConsultationController(_mocConsultationRepository.Object);

        }
        [Fact]
        public void GetAllConsultationsTest()
        {
            // [1.1] Подготовка данных для тестирования

            // [1.2]

            List<Consultation> list = new List<Consultation>();
            list.Add(new Consultation());
            list.Add(new Consultation());
            list.Add(new Consultation());


            _mocConsultationRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            // [2] Исполнение тестируемого метода

            _ConsultationController.GetAll();
            var operationResult = _ConsultationController.GetAll();

            // [3] Подготовка эталонногорезультата, проверка результата
            _mocConsultationRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());

        }
    }
}
