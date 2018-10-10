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
				sh "touch artifact.tar"
				sh "dotnet clean"
				sh "tar --exclude=artifact.tar -cvf artifact.tar ."
				sh "curl --unix-socket /var/run/docker.sock -X POST -H \"Content-Type:application/tar\" --data-binary '@artifact.tar' http:/v1.37/build?dockerfile=\"./src/HelloWorldJenkins/Dockerfile\"&t=build_test"
				sh "dotnet publish -o /var/artifact src/HelloWorldJenkins"
			}
        }
    }
}