$version='2.0.0'
dotnet build -c Release   /property:Version=$version
dotnet pack -c Release /property:Version=$version

$ostatniPakiet = (gci .\src\Voyager.DBSafeCast\bin\Release\*.nupkg | select -last 1).Name
$sciezka = ".\src\Voyager.DBSafeCast\bin\Release\$ostatniPakiet"

dotnet nuget push "$sciezka" -s Voyager-Poland