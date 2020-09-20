cd D:\Program Files\Octopus Deploy\OctopusCLI
octo push --package "D:\MyDev\DotNet\ASP_NET\softweb\softweb\obj\octopacked\softweb.1.0.0.3.nupkg"  --replace-existing --server http://localhost/octopus --apiKey API-CT1D3AXIIQRWTMPXKFV8YGP0G7Q
octo create-release --project=Softwe3  --deployto=TEST --server http://localhost/octopus --apiKey API-CT1D3AXIIQRWTMPXKFV8YGP0G7Q --releaseNotes "a new release " --progress


--------------------------------------------------------

for FILENAME in "D:\MyDev\DotNet\ASP_NET\softweb\softweb\obj\octopacked"/*
do
    echo "$FILENAME"
    cd "D:\Program Files\Octopus Deploy\OctopusCLI"
    octo push --package "$FILENAME"  --replace-existing --server http://localhost/octopus --apiKey API-CT1D3AXIIQRWTMPXKFV8YGP0G7Q
	octo create-release --project=Softwe3  --deployto=TEST --server http://localhost/octopus --apiKey API-CT1D3AXIIQRWTMPXKFV8YGP0G7Q --releaseNotes "a new release " --progress    
done