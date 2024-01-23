using MaxTemp.Data;
using MaxTemp.Logic;


var repo = new TemperatureRepository();

var service = new TemperatureService(repo);

var data = repo.GetAllSensors();