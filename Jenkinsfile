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
				sh """
					dotnet clean

					touch artifact.tar

					tar --exclude=artifact.tar --exclude=.git* --exclude=./test* --exclude=.vs* -cvf artifact.tar .

					curl --unix-socket /var/run/docker.sock \
						-X POST -H "Content-Type:application/x-tar" \
						--data-binary '@artifact.tar' \
						http:/v1.38/build?t=hello-world-jenkins

					curl --unix-socket /var/run/docker.sock -H "Content-Type: application/json" \
						-d '{"Image": "hello-world-jenkins", "HostConfig": {"PortBindings": {"80/tcp": [{"HostIp": "0.0.0.0", "HostPort": "5000" }]}}}' \
						-X POST http:/v1.24/containers/create?name=hello-world-jenkins

					curl --unix-socket /var/run/docker.sock -X POST http:/v1.24/containers/hello-world-jenkins/start
				"""
			}
        }
    }
}