docker build --tag mojo106/dotnet-webapp-docker:latest .\DotnetWebApp\
docker run --publish 5000:80 dotnet-webapp-docker
kubectl apply -f .\HelloK8s.deployment.yml
kubectl get svc

http://localhost

kubectl delete -f .\HelloK8s.deployment.yml