## Overview
- Poc.FeatureFlag is a proof-of-concept project designed to demonstrate the integration and management of feature flags using the Unleash library. 
- This project provides a basic implementation to control feature toggles in an application, allowing features to be enabled or disabled dynamically without changing the codebase.

Note: Feature flags in this project are managed from the GitLab Feature Flags interface


## How to use

1. Navigate to the Feature flags section in the GitLab interface and create a new feature flag.


2. If desired, determine which users should have access to the feature by setting a strategy. By default, I leave it as is.


3. Simply switch the status to turn the feature on or off.


4. Get Unleash settings from the Configure tab and add them to the appsettings.json file.


### illustration