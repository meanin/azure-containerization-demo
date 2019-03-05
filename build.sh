docker build -f ContainersDemo/ContainersDemo.PrivateApi/Dockerfile -t privateapi:latest ContainersDemo
docker build -f ContainersDemo/ContainersDemo.PublicApi/Dockerfile -t publicapi:latest ContainersDemo
 
docker tag privateapi:latest containersdemo.azurecr.io/privateapi:latest
docker tag publicapi:latest containersdemo.azurecr.io/publicapi:latest

docker push containersdemo.azurecr.io/privateapi:latest
docker push containersdemo.azurecr.io/publicapi:latest