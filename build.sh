cd src
dotnet restore
dotnet publish -c Release -o out
docker build -t skadisteam-inventory-proxy .
docker run -it --rm -p 5000:5000 -d skadisteam-inventory-proxy
cd ..

