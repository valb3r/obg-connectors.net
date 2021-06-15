#!/usr/bin/env bash

mkdir apis
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-banking-rest-api-ymls/src/main/resources/static/tpp_banking_api_commons.yml" > apis/tpp_banking_api_commons.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-banking-rest-api-ymls/src/main/resources/static/tpp_banking_api_bank_search.yml" > apis/tpp_banking_api_bank_search.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-banking-rest-api-ymls/src/main/resources/static/tpp_banking_api_ais.yml" > apis/tpp_banking_api_ais.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-banking-rest-api-ymls/src/main/resources/static/tpp_banking_api_pis.yml" > apis/tpp_banking_api_pis.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-banking-rest-api-ymls/src/main/resources/static/tpp_banking_api_token.yml" > apis/tpp_banking_api_token.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-auth-rest-api/src/main/resources/static/tpp_auth_api.yml" > apis/tpp_auth_api.yml
curl "https://raw.githubusercontent.com/adorsys/open-banking-gateway/develop/opba-consent-rest-api/src/main/resources/static/tpp_consent_api.yml" > apis/tpp_consent_api.yml

(
  cd apis || exit 1
  npx openapi-merge-cli
)

wget https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/5.1.1/openapi-generator-cli-5.1.1.jar -O openapi-generator-cli.jar


java -jar openapi-generator-cli.jar generate -i apis/merged-api.yml -g csharp-netcore -o csharp-netcore/obg-api --skip-validate-spec -p pubName=obg-api -p pubLibrary=obg-api \
     --global-property apiTests=false,modelTests=false --enable-post-process-file