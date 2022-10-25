# NFT-Assesment

To Run the project

Please set the starting projetc as NethereumSmartContracts.Api
appsettings.json required to fill 'InfuraUrl' url
which will launch Swagger endpoint 
https://localhost:7015/swagger/index.html

Expected request body

-X 'GET' \
  'https://localhost:7015/api/metadata?token={}' \
  -H 'accept: */*' \
  -H 'contractAddress: {} '
