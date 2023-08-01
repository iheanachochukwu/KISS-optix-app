# Optix Technical Test – DevOps

The test is to assess your practical skills. There is no specific time limit for this technical test, however, it should be completed within a reasonable time. 

You should consider:
- Pay attention to how you structure your project(s).
- Remember KISS! Keep things simple, do not get bogged down in trying to be too complicated. It’s better to complete the basic requirements and then go back to improve further if you feel you have the time.
- If you have any questions or get stuck on anything at all, please reach out to us!

## The Task

Our developer has created an API but needs your help to containerise the application and deploy it.

Your task is to take what the developer has attempted so far, optimise it and then create a basic deployment pipeline.

## Contextual Information

The functionality of the API & Application is not the focus for this exercise, rather concentrate on the build and deployability.

You have demonstrated experience with Azure DevOps and its build and release pipelines, as such, assume that it is the deployment tool of choice for this exercise. If you decide to use an alternative, please explain the rationale behind your decision.

## Acceptance Criteria

### Must have
- Transform the current Dockerfile to a multi staged one.
- Create a .yaml file to build your application using the previous Dockerfile.
- Create a helm chart to deploy your docker image to you Kubernetes.


### Should have
- The Dockerfile should have build, test, and publish stages.
- The .yaml build pipeline should fail in case any of the previous steps have failed
- The helm chart should allow us to override a variable during deployment.


### Could have
- Decrease the docker image size to the smallest available one.
- Build pipeline should show the test results and code coverage target.
- Helm chart should allow us to define an URL for the ingress route.

## Sharing

Once completed please provide us with copies of your project files you can do this via any file sharing provider or provide a link to the repository that we can access and download the solution from.

If you have any questions regarding the tech test, even if you get stuck, please don’t hesitate to reach out and ask us!

