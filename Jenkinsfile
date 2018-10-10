pipeline {
    agent any

	options {
		skipDefaultCheckout true
	}

	stages {
        stage('checkout') {
            steps {
                checkout scm
            }
        }

        stage('build') {
			steps {
				sh "dotnet build src/HelloWorldJenkins"
			}
        }

        stage('test') {
			steps {
				sh "dotnet test test/HelloWorldJenkins.UnitTests"
			}
        }

        stage('deploy') {
			steps {
				sh "touch artifact.tar.gz"
				sh "dotnet clean"
				sh "tar --exclude=artifact.tar.gz -zcvf artifact.tar.gz ."
				sh "curl -v -X POST -H \"Content-Type:application/tar\" --data-binary '@artifact.tar.gz' http://localhost/build?t=build_test"
				sh "dotnet publish -o /var/artifact src/HelloWorldJenkins"
			}
        }
    }
}