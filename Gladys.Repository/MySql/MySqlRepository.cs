﻿using System;
using System.Collections.Generic;
using Gladys.Repository.Log;
using Gladys.Repository.Model;

namespace Gladys.Repository.MySql
{
  public class MySqlRepository : IRepository
  {
    private MySqlConnectionManager _manager;
    private MySqlConnectionConfig _config;
    private ILogger _logger;
    
    public MySqlRepository(MySqlConnectionConfig config, ILogger logger = null)
    {
      _manager = new MySqlConnectionManager(logger);
      _config = config;
    }

    public IEnumerable<IDataEntity> GetAll(string type)
    {
      _manager.GetConnection(_config);
      _manager.Disconnect();
      
      return null;
    }

    public IEnumerable<IDataEntity> GetById(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}
