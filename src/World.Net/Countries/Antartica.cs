﻿namespace World.Net.Countries;

internal sealed class Antartica : ICountry
{
    ///<inheritdoc/>
    public int Id { get; } = CountryIdentifier.Antarctica;

    ///<inheritdoc/>
    public string Name { get; } = nameof(Antartica);

    ///<inheritdoc/>
    public string OfficialName { get; } = nameof(Antartica);

    ///<inheritdoc/>
    public string NativeName { get; } = nameof(Antartica);

    ///<inheritdoc/>
    public string Capital { get; } = string.Empty;

    ///<inheritdoc/>
    public int NumericCode { get; } = 010;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AQ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ATA";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+672";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } = [];
}
