helm repo add bitnami https://charts.bitnami.com/bitnami

helm install redis --set auth.password=password --set replica.replicaCount=2 --set image.repository=redis --set image.tag=7.0.5 bitnami/redis
