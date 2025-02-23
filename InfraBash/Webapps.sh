# Function app and storage account names must be unique.

# Variable block
let "randomIdentifier=$RANDOM*$RANDOM"
location="westus"
resourceGroup="learn-cfc54bec-761d-47e9-bcf7-47d4cbde0ac5"
tag="create-function-app-consumption"
# storage="msdocsaccount$randomIdentifier"
# functionApp="msdocs-serverless-function-$randomIdentifier"
appServicePlanName="godowngo-asp-$randomIdentifier"
webappname="godowngo-web-$randomIdentifier"

# Create a resource group
# echo "Creating $resourceGroup in "$location"..."
# az group create --name $resourceGroup --location "$location" --tags $tag

# Create an Azure storage account in the resource group.
# echo "Creating $storage"
# az storage account create --name $storage --location "$location" --resource-group $resourceGroup --sku $skuStorage

# Create a serverless function app in the resource group.
# echo "Creating $functionApp"
# az functionapp create --name $functionApp --storage-account $storage --consumption-plan-location "$location" --resource-group $resourceGroup --functions-version $functionsVersion

echo "Creating app service plane starte..."
az appservice plan create --name $appServicePlanName --resource-group $resourceGroup --location $location --sku S1
echo "Creating app service plane end..."

echo "Creating webapps starte..."
az webapp create --name $webappname --resource-group $resourceGroup --plan $appServicePlanName
echo "Creating webapps end..."

# Setup a connection string for the Web App to access our previously created MySQL instance (running in same resource group)
# az webapp config connection-string set --resource-group $demoresourcegroup --name $webappname -t mysql --settings defaultconnection="Data Source=${mysqlservername}.mysql.database.azure.com; User Id=${mysqladminuser}@${mysqlservername}; Password=${mysqladminpass}"