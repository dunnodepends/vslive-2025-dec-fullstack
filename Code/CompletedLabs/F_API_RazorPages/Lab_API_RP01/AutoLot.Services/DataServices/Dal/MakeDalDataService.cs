// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - MakeDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class MakeDalDataService(
    IAppLogging appLoggingInstance,
    IMakeRepo makeRepoInstance)
    : DalDataServiceBase<Make>(appLoggingInstance, makeRepoInstance), IMakeDataService
{
}