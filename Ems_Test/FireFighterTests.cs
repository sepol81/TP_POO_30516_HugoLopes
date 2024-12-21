using EMS.Data;
using EMS.enums;
using EMS.models.Persons;
using EMS.services;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace EMS.Tests
{
    public class FireFighterTests
    {
        private readonly DbContextOptions<EMS_DBContext> _options;

        public FireFighterTests()
        {
            // Configuração do banco de dados em memória
            _options = new DbContextOptionsBuilder<EMS_DBContext>()
                        .UseInMemoryDatabase(databaseName: "TestDb")
                        .Options;
        }

        private EMS_DBContext CreateContext()
        {
            return new EMS_DBContext(_options);
        }

        // Classe derivada fictícia para testes
        private class TestFireFighter : FireFighter
        {
            public TestFireFighter(string Name, string CitCard, Profession Profession, StatusPerson Status, DateOnly Birthday,
                string Email, string Phone, string Address, RankFireFighter Rank, int YearsOfExp, List<string> Certifications, List<string> Skills)
                : base(Name, CitCard, Profession, Status, Birthday, Email, Phone, Address, Rank, YearsOfExp, Certifications, Skills)
            {
            }
        }

        [Fact]
        public void FireFighter_Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            var certifications = new List<string> { "Fire Safety", "First Aid" };
            var skills = new List<string> { "Fire Fighting", "Rescue Operations" };
            var firefighter = new TestFireFighter(
                "John Doe",
                "123456789",
                Profession.Bombeiro,
                StatusPerson.EmServiço,
                new DateOnly(1985, 5, 15),
                "johndoe@example.com",
                "555-1234",
                "123 Main St",
                RankFireFighter.SubChefe,
                10,
                certifications,
                skills
            );

            // Act & Assert
            Assert.Equal("John Doe", firefighter.Name);
            Assert.Equal(RankFireFighter.SubChefe, firefighter.Rank);
            Assert.Equal(10, firefighter.YearsOfExp);
            Assert.Equal(certifications, firefighter.Certifications);
            Assert.Equal(skills, firefighter.Skills);
        }

        [Fact]
        public void FireFighter_ShouldThrowArgumentNullException_WhenNameIsNull()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new TestFireFighter(
                null, // Name is null
                "123456789",
                Profession.Bombeiro,
                StatusPerson.EmServiço,
                new DateOnly(1985, 5, 15),
                "johndoe@example.com",
                "555-1234",
                "123 Main St",
                RankFireFighter.SubChefe,
                10,
                new List<string> { "Fire Safety", "First Aid" },
                new List<string> { "Fire Fighting", "Rescue Operations" }
            ));
        }

        
    }
}
