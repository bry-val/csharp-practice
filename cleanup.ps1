# Get the path to the solution file
$solutionPath = "C:\csharp studying\csharp studying.sln"  # Modify this to the correct solution file path

# Get all .csproj file paths up to 2 levels deep
$csprojFiles = Get-ChildItem -Path . -Filter "*.csproj" -Recurse -Depth 2 | Select-Object -ExpandProperty FullName

# Loop through each .csproj file and add it to the solution
foreach ($csprojFile in $csprojFiles) {
    Write-Output "Adding project: $csprojFile"
    dotnet sln $solutionPath add $csprojFile
}
