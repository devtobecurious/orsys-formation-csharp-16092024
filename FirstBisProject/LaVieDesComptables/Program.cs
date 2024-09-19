using LaVieDesComptables;

Computer computer = new();
var result = computer.Compute(10, 0.2M);

result = computer.Compute(20, countryCode =>
{
    return 19.6M;
});