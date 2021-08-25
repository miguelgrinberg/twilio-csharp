.PHONY: clean test install release docs

clean:
	dotnet clean

install:
	@dotnet --version || (echo "Dotnet is not installed, please install Dotnet CLI"; exit 1);
	dotnet restore

test:
	dotnet build -c Release
	dotnet test -c Release

release:
	dotnet pack -c Release

docs:
	doxygen Doxyfile

API_DEFINITIONS_SHA=$(shell git log --oneline | grep Regenerated | head -n1 | cut -d ' ' -f 5)
docker-build:
	docker build -t twilio/twilio-csharp .
	docker tag twilio/twilio-csharp twilio/twilio-csharp:${TRAVIS_TAG}
	docker tag twilio/twilio-csharp twilio/twilio-csharp:apidefs-${API_DEFINITIONS_SHA}
	docker tag twilio/twilio-csharp twilio/twilio-csharp:latest

docker-push:
	echo "${DOCKER_PASSWORD}" | docker login -u "${DOCKER_USERNAME}" --password-stdin
	docker push twilio/twilio-csharp:${TRAVIS_TAG}
	docker push twilio/twilio-csharp:apidefs-${API_DEFINITIONS_SHA}
	docker push twilio/twilio-csharp:latest

cover:
	dotnet sonarscanner begin /k:"twilio_twilio-csharp" /d:sonar.host.url=https://sonarcloud.io /o:"twilio" /d:sonar.login="${SONAR_TOKEN}" /d:sonar.language="cs" /d:sonar.exclusions="src/Twilio/Rest/**/*.*,test/Twilio.Test/**/*.*" /d:sonar.cs.opencover.reportsPaths="test/lcov.net451.opencover.xml"
	# Write to a log file since the logs for build with sonar analyzer are pretty beefy and travis has a limit on the number of log lines
	dotnet build Twilio.sln > buildsonar.log
	dotnet test test/Twilio.Test/Twilio.Test.csproj --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=../lcov
	dotnet sonarscanner end /d:sonar.login="${SONAR_TOKEN}"

cache:
	directories:
		- '$HOME/.sonar/cache'
