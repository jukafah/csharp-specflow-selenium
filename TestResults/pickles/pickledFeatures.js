jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "../Demo.feature",
      "Feature": {
        "Name": "Demo",
        "Description": "As a User,\nI can find information about libraries this demo uses",
        "FeatureElements": [
          {
            "Name": "Google Search - FluentAssertions",
            "Slug": "google-search---fluentassertions",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on \"http://www.google.com\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search for \"Fluent Assertions\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "select \"Fluent Assertions - Fluent Assertions\" in the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I am presented with the \"Fluent Assertions - Fluent Assertions\" homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@C001",
              "@smokeTest"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Name": "Google Search - SpecFlow",
            "Slug": "google-search---specflow",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on \"http://www.google.com\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search for \"SpecFlow\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "select \"SpecFlow\" in the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I am presented with the \"SpecFlow - Binding Business Requirements to .NET Code\" homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@C002",
              "@regression"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Name": "Google Search - Selenium",
            "Slug": "google-search---selenium",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on \"http://www.google.com\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search for \"Selenium\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "select \"Selenium - Web Browser Automation\" in the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I am presented with the \"Selenium - Web Browser Automation\" homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@C003",
              "@smokeTest"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Name": "Google Search - JetBrains Rider",
            "Slug": "google-search---jetbrains-rider",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on \"http://www.google.com\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search for \"JetBrains Rider\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "select \"Rider: The Cross-Platform .NET IDE from JetBrains\" in the search results",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I am presented with the \"Rider: The Cross-Platform .NET IDE from JetBrains\" homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@C004",
              "@regression"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true,
          "WasProvided": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true,
        "WasProvided": true
      }
    },
    {
      "RelativeFolder": "../LoremIpsum.feature",
      "Feature": {
        "Name": "Lorem Ipsum",
        "Description": "As a User,\nI can generate variations of Lorem Ipsum text",
        "FeatureElements": [
          {
            "Name": "Paragraphs - Generate with starting text",
            "Slug": "paragraphs---generate-with-starting-text",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I generate text with default starting text",
                "TableArgument": {
                  "HeaderRow": [
                    "Amount",
                    "Text Generation Type",
                    "Start With Default Text"
                  ],
                  "DataRows": [
                    [
                      "5",
                      "Paras",
                      "True"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the paragraphs are generated correctly",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Name": "Paragraphs - Generate without starting text",
            "Slug": "paragraphs---generate-without-starting-text",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I generate text without default starting text",
                "TableArgument": {
                  "HeaderRow": [
                    "Amount",
                    "Text Generation Type",
                    "Start With Default Text"
                  ],
                  "DataRows": [
                    [
                      "5",
                      "Paras",
                      "False"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the paragraphs are generated correctly",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Name": "Words - Generate with starting text",
            "Slug": "words---generate-with-starting-text",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I generate text with default starting text",
                "TableArgument": {
                  "HeaderRow": [
                    "Amount",
                    "Text Generation Type",
                    "Start With Default Text"
                  ],
                  "DataRows": [
                    [
                      "5",
                      "Words",
                      "True"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the words are generated correctly",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": true
            }
          },
          {
            "Name": "Words - Generate without starting text",
            "Slug": "words---generate-without-starting-text",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the homepage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I generate text without default starting text",
                "TableArgument": {
                  "HeaderRow": [
                    "Amount",
                    "Text Generation Type",
                    "Start With Default Text"
                  ],
                  "DataRows": [
                    [
                      "5",
                      "Words",
                      "False"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the words are generated correctly",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true,
          "WasProvided": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true,
        "WasProvided": true
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@C001",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@smokeTest",
        "Total": 2,
        "Passing": 2,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@C002",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@regression",
        "Total": 2,
        "Passing": 2,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@C003",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@C004",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "../Demo.feature",
        "Total": 4,
        "Passing": 4,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "../LoremIpsum.feature",
        "Total": 4,
        "Passing": 2,
        "Failing": 0,
        "Inconclusive": 2
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "../Demo.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "../LoremIpsum.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 8,
      "Passing": 6,
      "Failing": 0,
      "Inconclusive": 2
    },
    "Features": {
      "Total": 2,
      "Passing": 2,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "GeneratedOn": "29 January 2019 09:49:13"
  }
});