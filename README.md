# NFT-Assesment

To Run the project

Please set the starting projetc as NethereumSmartContracts.Api and on starting, sln will launch Swagger page https://localhost:7015/swagger/index.html

- appsettings.json required to fill 'InfuraUrl' url

- Expected request body

-X 'GET' \
  'https://localhost:7015/api/metadata?token={}' \
  -H 'accept: */*' \
  -H 'contractAddress: {} '
