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
				sh "tar -zcvf ./HelloWorldJenkins.tar.gz ."
				//sh "curl -XPOST --unix-socket /var/run/docker.sock -F 'data=@./HelloWorldJenkins.tar.gz' -H 'Content-Type: application/x-tar' http://localhost/build"
				sh "dotnet publish -o /var/artifact src/HelloWorldJenkins"
			}
        }
    }
}