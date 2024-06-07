## Overview
- Poc.FeatureFlag is a proof-of-concept project designed to demonstrate the integration and management of feature flags using the Unleash library. 
- This project provides a basic implementation to control feature toggles in an application, allowing features to be enabled or disabled dynamically without changing the codebase.

Note: Feature flags in this project are managed from the GitLab Feature Flags interface


## How to use

1. Navigate to the Feature flags section in the GitLab interface and create a new feature flag.
   
![1](https://github.com/BekirK-C/Poc.FeatureFlag/assets/80921292/b05a5583-d481-4aca-878e-fc1f23371301)


2. If desired, determine which users should have access to the feature by setting a strategy. By default, I leave it as is.
   
![2](https://github.com/BekirK-C/Poc.FeatureFlag/assets/80921292/9e819d04-d600-47fd-a7a0-0aaf4951e06d)


3. Simply switch the status to turn the feature on or off.
   
![3](https://github.com/BekirK-C/Poc.FeatureFlag/assets/80921292/dd9a7265-b285-4d3b-ad46-7fb9be01207f)


4. Get Unleash settings from the Configure tab and add them to the appsettings.json file.
   
![4](https://github.com/BekirK-C/Poc.FeatureFlag/assets/80921292/4d461a9c-8455-4643-a098-e51a2f19449b)


### Illustration

![Adsız tasarım](https://github.com/BekirK-C/Poc.FeatureFlag/assets/80921292/325b3926-d812-49c6-a13d-82f12aa5017c)
