# GraphQLDemo

This is a demo application with C# and graphql for the beginners.

**What is GraphQL?**

GraphQL is a query language for your APIs that can be used to get only the required information. It allows you to query for exactly the fields you want solving the problem of over fetching and under fetching.

What problem it solves?

The GraphQL solves the following problems.

Over fetching and under fetching of data

GraphQL is database neutral technology that provides flexibility to the client to get data from multiple servers in a single response.

Development is faster due to the fact that client has more flexibility in fetching the data.

A single query can return response with multiple resources saving the cost of multiple calls.

As client can request exactly the what it needs results in improving the performance of application.

It includes in built support for real time updates with subscriptions. 

GraphQL APIs are self documenting resulting the developers to explore the schema.

**Components of GraphQL**

The GraphQL consists of the following components:

Schema: This is the most important component of GraphQL. It describes the types of data provided by the API, the relationships between these types, and the operations that can be performed.

Query: This is a read operation in GraphQL. Clients use queries to request specific data from the API.

Mutation: This is a write operation in GraphQL. Clients use mutations to create, update, or delete data.

Subscription: This is a real-time operation in GraphQL. Clients use subscriptions to receive real-time updates from the server.

Resolver: This is a function that connects a GraphQL query to its data source. Resolvers are responsible for fetching the data for individual fields in a schema.

Type System: GraphQL uses a strong type system to define the capabilities of an API. All the types that are possible to send and receive from an API are defined in advance.


