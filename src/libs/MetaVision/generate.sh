install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace MetaVision \
  --clientClassName MetaVisionClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
