pipeline {
    agent any

	options {
		skipDefaultCheckout true
	}

    environment {
        MY_SECRET = 'second secret'
    }

	stages {
        stage('checkout') {
            steps {
                checkout scm
            }
        }

        stage('build') {
			steps {
				sh """
					set +x

					echo ''

					dotnet build src/HelloWorldJenkins
				"""
				
				sh """
					set +x
					
					echo ${MY_SECRET}

					curl -X GET \
						http://google.com
						
					dotnet build src/HelloWorldJenkins
				"""

				sh	"""
					set +x

					curl --unix-socket /var/run/docker.sock \
						-X POST -H "Content-Type:application/x-tar" \
						--data-binary '@artifact.tar' \
						http:/v1.38/build?t=hello-world-jenkins
				"""
			}
        }

        // stage('test') {
		// 	steps {
		// 		sh "dotnet test test/HelloWorldJenkins.UnitTests"
		// 	}
        // }
		
		// stage('build docker image') {
		// 	steps {
		// 		sh "dotnet clean"
		
		// 		sh "touch artifact.tar"
		
		// 		sh "tar --exclude=artifact.tar --exclude=.git* --exclude=./test* --exclude=.vs* -cvf artifact.tar ."
		
		// 		// It shows in Jenkins step log regardless of set +x set
		// 		sh	"""
		// 			set +x

		// 			curl --unix-socket /var/run/docker.sock \
		// 				-X POST -H "Content-Type:application/x-tar" \
		// 				--data-binary '@artifact.tar' \
		// 				http:/v1.38/build?t=hello-world-jenkins
		// 		"""
		// 	}
		// }
		
		// stage('teardown old container') {
		// 	steps {
		// 		sh """
		// 			curl --unix-socket /var/run/docker.sock \
		// 				-X DELETE \
		// 				http:/v1.38/containers/hello-world-jenkins?force=1
		// 		"""
		// 	}
		// }
		
        // stage('deploy new container') {
		// 	steps {
		// 		sh """
		// 			curl --unix-socket /var/run/docker.sock \
		// 				-H "Content-Type: application/json" \
		// 				-d @create-container.json \
		// 				-X POST \
		// 				http:/v1.38/containers/create?name=hello-world-jenkins
		// 		"""
		
		// 		sh "curl --unix-socket /var/run/docker.sock -X POST http:/v1.24/containers/hello-world-jenkins/start"
		// 	}
        // }
    }
}