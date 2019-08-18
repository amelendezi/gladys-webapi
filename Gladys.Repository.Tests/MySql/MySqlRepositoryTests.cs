﻿using Gladys.Repository.Log;
using Gladys.Repository.MySql;
using NUnit.Framework;

namespace Gladys.Repository.Tests.MySql
{
    [TestFixture]
    public class MySqlRepositoryTests
    {
        [Test]
        public void On_GetAll_ReturnsCorrectResult()
        {
            var config = MySqlConnectionStringParser.Load(MySqlTestConstants.ConnectionConfigPath);
            var logger = new StringBuilderLogger();
            
            var _sut = new MySqlRepository(config, logger);

            _sut.GetAll("default");
        }
    }
}