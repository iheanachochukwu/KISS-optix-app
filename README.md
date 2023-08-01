# labs

# Deploy Helm chart

- From charts directory

To deploy the Helm chart, and run the following command:

```bash
$ helm upgrade optix ./charts/optix --values ./charts/optix/values.yaml --install --force

helm upgrade --install optix-helm --create-namespace --namespace optix --values ./charts/optix/values.yaml ./charts/optix --force
```

```yaml
Release "optix" has been upgraded. Happy Helming!
NAME: optix
LAST DEPLOYED: Mon Jul 31 00:45:08 2023
NAMESPACE: default
STATUS: deployed
REVISION: 2
NOTES:
optix test for helm
```
