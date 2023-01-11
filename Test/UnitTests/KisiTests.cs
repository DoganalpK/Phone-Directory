using Contact.Microservice.Models.Domain;
using Contact.Microservice.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace UnitTests
{
    public class KisiTests
    {
        private readonly IGenericRepository<Kisiler> _repository;

        public KisiTests(IGenericRepository<Kisiler> repository)
        {
            _repository = repository;
        }

        public void Add_Test()
        {
            var testObject = new TestClass();
            var context = new Mock<DbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();
            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<TestClass>())).Returns(testObject);

            // Act
            var repository = new GenericRepository<TestClass>(context);
            repository.CreateAsync(testObject);

            //Assert
            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Add(It.Is<TestClass>(y => y == testObject)));
        }
    }
}
