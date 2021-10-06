#####set /p nugetServer=Enter base nuget server url (with /): 
if ($IsMacOS) {
    $msbuild = "msbuild"
} else {
    $vswhere = 'C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe'
    $msbuild = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
    $msbuild = join-path $msbuild 'MSBuild\Current\Bin\MSBuild.exe'
}

$version="0.0.1"
$versionSuffix=""
$nugetVersion="$version$versionSuffix"
#$versionSuffix=".$env:BUILD_NUMBER" 

#####################
#Build release config
cd $PSScriptRoot
del *.nupkg
& $msbuild "..\OpenCvBinding.sln" /restore /p:Configuration=Release /p:Platform="Any CPU" /p:Version="$version" /p:VersionSuffix="$versionSuffix" /p:Deterministic=false /p:PackageOutputPath="$PSScriptRoot" --% /t:Clean;Build
if ($lastexitcode -ne 0) { exit $lastexitcode; }

####################
#Distribute


nuget pack "Softlion.OpenCvBinding.nuspec" -Version $version
#dotnet nuget push "Softlion.OpenCvBinding.$nugetVersion.nupkg"
