// Copyright Information
// ==================================
// AutoLot - AutoLot.Api - DriversController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/06
// ==================================

namespace AutoLot.Api.Controllers;

public class DriversController(IAppLogging appLogging, IDriverRepo repo)
    : BaseCrudController<Driver>(appLogging, repo);
