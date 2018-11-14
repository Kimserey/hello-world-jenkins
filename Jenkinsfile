@Library('my-shared-library') _

def variable = "Hello"

stage ("Shared Library Test") {
  
  log.info "test info!"
  
  log {
    type = "warning"
    message = "test warning closure!"
  }


  log {
    type = "info"
    message = variable
  }
}