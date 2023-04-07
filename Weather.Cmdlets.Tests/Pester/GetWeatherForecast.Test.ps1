Describe "Get-WeatherForecast" {
    it "Should return weather" {
        if (-not (Get-Module -ListAvailable -Name Pester | Where-Object {$_.Version -eq "5.2.2"})) {
            Install-Module -Name Pester -RequiredVersion 5.2.2 -Scope CurrentUser -Force
        }

        if (-not (Get-Module -Name Pester)) {
            Import-Module Pester -RequiredVersion 5.2.2 -Force
        }

        If (-not (Get-Module Weather.Cmdlets))
        {
            $pathToCmdletsProject = "$PSScriptRoot/../../Weather.Cmdlets"
            dotnet build "$pathToCmdletsProject/Weather.Cmdlets.csproj" -c Release
            Import-Module "$pathToCmdletsProject/bin/Release/net6.0/WeatherCmdlets.psd1"
        }

        $weather = Get-WeatherForecast

        $weather | Should -Not -BeNullOrEmpty
    }
}
