﻿namespace JOIEnergy.Services;

public interface IMeterReadingService
{
    List<ElectricityReading> GetReadings(string smartMeterId);
    void StoreReadings(string smartMeterId, List<ElectricityReading> electricityReadings);
}