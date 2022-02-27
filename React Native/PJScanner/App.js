import React from 'react';
import { StyleSheet } from 'react-native';
import { createAppContainer } from 'react-navigation';

//my lib
import AppNavigator from './AppNavigator';

const AppContainer = createAppContainer(AppNavigator);

export default class App extends React.Component {
  render() {
    return <AppContainer />;
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'stretch', //alignItems: 'stretch' can le tran 2 ben
    backgroundColor: '#fff',
    justifyContent: 'center',
    paddingLeft: 16,
    paddingRight: 16,

  },
});
